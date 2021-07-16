<?php
include 'database/koneksi.php';

$NIK = $_POST['NIK'];
$keterangan = $_POST['keterangan'];
$izin_tanggal = $_POST['izin_tanggal'];
$sampai_tanggal = $_POST['sampai_tanggal'];
$created_at = $_POST['created_at'];

$data = mysqli_query($koneksi,"select * from karyawan where NIK='$NIK'");
 
if($data->num_rows > 0){
	$sql="INSERT INTO izin (NIK,keterangan,izin_tanggal,sampai_tanggal,created_at) values ('$NIK','$keterangan','$izin_tanggal','$sampai_tanggal','$created_at')";
    mysqli_query($koneksi,$sql) or die ('gagal');
    echo '<script>alert("Berhasil menambah data."); document.location="index.php";</script>';
}else{
    echo '<script>alert("NIK anda salah."); document.location="index.php?pesan=error";</script>';
}

?>