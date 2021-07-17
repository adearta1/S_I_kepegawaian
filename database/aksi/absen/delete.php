<?php
include_once("../../koneksi.php");
$hapus=$_GET['id_absen'];
$sql="DELETE FROM absensi WHERE id_absen='$hapus'";
$delete = $koneksi->query($sql);
if($delete){ header("location:../../absen.php"); }
?>