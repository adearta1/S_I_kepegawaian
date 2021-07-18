<?php
include_once("../../koneksi.php");
$hapus=$_GET['id_pendidikan'];
$sql="DELETE FROM pendidikan WHERE id_pendidikan='$hapus'";
$delete = $koneksi->query($sql);
if($delete){ header("location:../../pendidikan.php"); }
?>