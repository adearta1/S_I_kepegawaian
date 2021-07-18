<?php
include_once("../../koneksi.php");
$hapus=$_GET['id_izin'];
$sql="DELETE FROM izin WHERE id_izin='$hapus'";
$delete = $koneksi->query($sql);
if($delete){ header("location:../../izin.php"); }
?>