<?php
// mengaktifkan session php


session_start();

if($_COOKIE['login']){
	if($_COOKIE['login']='true'){
	  $_SESSION['status']=true;
	}
} 
// menghubungkan dengan koneksi
include 'database/koneksi.php';
 
// menangkap data yang dikirim dari form
$username = $_POST['username'];
$password = $_POST['password'];
 
// menyeleksi data admin dengan username dan password yang sesuai
$data = mysqli_query($koneksi,"select * from admin where username='$username' and password='$password'");
 
// menghitung jumlah data yang ditemukan
$cek = mysqli_num_rows($data);
 
if($cek > 0){
	$_SESSION['username'] = $username;
	$_SESSION['status'] = "login";
	if (isset($_POST['remember'])){
		setcookie('status','true',time()+3600);
	}
	header("location:database/index.php");
}else{
	header("location:login.php?pesan=gagal");
}
?>