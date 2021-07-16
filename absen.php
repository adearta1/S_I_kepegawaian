<?php
include 'database/koneksi.php';

$NIK = $_POST['NIK'];
$keterangan = $_POST['keterangan'];
$tanggal = $_POST['tanggal'];
 
$data = mysqli_query($koneksi,"select * from karyawan where NIK='$NIK'");
 
if($data->num_rows > 0){
	$sql="INSERT INTO absensi (NIK,keterangan,tanggal) values ('$NIK','$keterangan','$tanggal')";
    mysqli_query($koneksi,$sql) or die ('gagal');
    echo '<script>alert("Berhasil menambah data."); document.location="index.php";</script>';
}else{
    echo '<script>alert("NIK anda salah."); document.location="index.php?pesan=error";</script>';
}
?>