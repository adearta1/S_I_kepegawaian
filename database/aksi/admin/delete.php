<?php
include_once("../../koneksi.php");
$hapus=$_GET['id_admin'];
$sql="DELETE FROM admin WHERE id_admin='$hapus'";
$delete = $koneksi->query($sql);
if($delete){ header("location:../../admin.php"); }
?>