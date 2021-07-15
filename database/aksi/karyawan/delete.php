<?php
include_once("../../koneksi.php");
$hapus=$_GET['NIK'];
$sql="DELETE FROM karyawan WHERE NIK='$hapus'";
$delete = $koneksi->query($sql);
if($delete){ header("location:../../datadiri.php"); }
?>