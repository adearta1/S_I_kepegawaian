<?php

    require_once 'koneksi.php';
    $sql ="SELECT * FROM karyawan WHERE NIK";
    $query = $koneksi->query($sql);

?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous">
    
    <title>Document</title>
</head>
<body>
    <?php 
    session_start();
    if($_SESSION['status']!="login"){
      header("location:../login.php?pesan=belum_login");
    }
    ?>
    <script language="javascript">
    function tanya() {
      if (confirm ("Apakah Anda yakin akan menghapus data ini ?")) {
        return true;
      } else {
        return false;
      }
    }
    </script>

    <!-- Optional JavaScript; choose one of the two! -->

    <!-- Option 1: jQuery and Bootstrap Bundle (includes Popper) -->
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ho+j7jyWK8fNQe+A12Hb8AhRq26LrZ/JpcUGGOn+Y7RsweNrtN/tE3MoK7ZeZDyx" crossorigin="anonymous"></script>

    <!-- Option 2: jQuery, Popper.js, and Bootstrap JS
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.min.js" integrity="sha384-w1Q4orYjBQndcko6MimVbzY0tgp4pWB4lZ7lr30WKz0vr/aWKhXdBNmNb5D92v7s" crossorigin="anonymous"></script>
    -->

    <nav class="navbar navbar-expand-lg navbar-dark bg-primary">
      <a class="navbar-brand text-light font-weight-bold" href="index.php">Hobimegel</a>
      <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarText" aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>
      <div class="collapse navbar-collapse" id="navbarText">
        <ul class="navbar-nav mr-auto">
          <li class="nav-item active">
            <a class="nav-link" href="index.php">Home <span class="sr-only">(current)</span></a>
            <li class="nav-item">
                <a class="nav-link" href="admin.php">Admin</a>
            </li>
            <li class="nav-item dropdown">
              <a class="nav-link dropdown-toggle" href="#" id="navbarDropdownMenuLink" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                Karyawan
              </a>
              <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                <a class="dropdown-item" href="datadiri.php">Data diri</a>
                <a class="dropdown-item" href="pendidikan.php">Pendidikan</a>
              </div>
            </li>
            <li class="nav-item dropdown">
              <a class="nav-link dropdown-toggle" href="#" id="navbarDropdownMenuLink" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                Absensi
              </a>
              <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                <a class="dropdown-item" href="absen.php">Absen</a>
                <a class="dropdown-item" href="izin.php">Izin</a>
              </div>
            </li>
        </ul>
        <span class="navbar-text font-weight-bold text-light">
          <?php echo $_SESSION['username']; ?>
          <a href="logout.php" class="btn btn-danger btn-sm active" role="button" aria-pressed="true">Logout</a>
        </span>
      </div>
    </nav>

    <div class="container-fluid mt-5">
      <nav class="navbar navbar-light bg-dark">
        <span class="navbar-brand text-light mb-0 h1">Data Karyawan</span>
      </nav>
      <nav class="navbar navbar-light bg-dark">
          <a href="aksi/karyawan/tambahdata.php" class="btn btn-primary btn-md active" role="button" aria-pressed="true">+ Tambah Data</a>
          <form action="datadiri.php" method="get" class="form-inline">
              <input name="cari" class="form-control mr-sm-2" type="search" placeholder="Search" aria-label="Search">
              <button  class="btn btn-primary my-2 my-sm-0" type="submit">Search</button>
          </form>
      </nav>
      <table class="table mt-2 table-striped">
        <thead class="thead-dark">
          <tr>
            <th scope="col">NIK</th>
            <th scope="col">Nama Karyawan</th>
            <th scope="col">Tanggal Lahir </th>
            <th scope="col">Agama</th>
            <th scope="col">Jenis Kelamin</th>
            <th scope="col">Alamat</th>
            <th scope="col">Telepon</th>
            <th scope="col">Email</th>
            <th scope="col">Jabatan</th>
            <th scope="col">Created at</th>
            <th scope="col">Update at</th>
            <th scope="col">Action</th>
          </tr>
        </thead>
        <tbody>
          <?php
          if(isset($_GET['cari'])){
            $cari = $_GET['cari'];
            $query = mysqli_query($koneksi,"SELECT * FROM karyawan WHERE NIK LIKE '%$cari%' 
            OR nama_karyawan LIKE '%$cari%'
            OR telepon LIKE '%$cari%'
            OR email LIKE '%$cari%'");    
           }else{
            $query = mysqli_query($koneksi,"SELECT * FROM karyawan ");  
           }
          while($d = mysqli_fetch_array($query)){
          ?>
          <tr>
            <th scope="row"><?php echo $d['NIK']; ?></th>
            <td><?php echo $d['nama_karyawan']; ?></td>
            <td><?php echo $d['tanggal_lahir']; ?></td>
            <td><?php echo $d['agama']; ?></td>
            <td><?php echo $d['jenis_kelamin']; ?></td>
            <td><?php echo $d['alamat']; ?></td>
            <td><?php echo $d['telepon']; ?></td>
            <td><?php echo $d['email']; ?></td>
            <td><?php echo $d['kd_jabatan']; ?></td>
            <td><?php echo $d['created_at']; ?></td>
            <td><?php echo $d['update_at']; ?></td>
            <td class="text-center">
              <a href="aksi/karyawan/edit.php?NIK=<?php echo $d['NIK']; ?>" class="btn btn-primary btn-sm active" role="button" aria-pressed="true">Edit</a>
              <a href="aksi/karyawan/delete.php?NIK=<?php echo $d['NIK'] ; ?>" onClick='return tanya()' class="btn btn-danger btn-sm active" role="button" aria-pressed="true">Delete</a>
            </td>
          </tr>
          <?php
          }
          ?>
        </tbody>
      </table>       
    </div>
    
</body>
</html>