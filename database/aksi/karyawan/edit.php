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
      header("location:../../../login.php?pesan=belum_login");
    }
    ?>
    <!-- Optional JavaScript; choose one of the two! -->

    <!-- Option 1: jQuery and Bootstrap Bundle (includes Popper) -->
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ho+j7jyWK8fNQe+A12Hb8AhRq26LrZ/JpcUGGOn+Y7RsweNrtN/tE3MoK7ZeZDyx" crossorigin="anonymous"></script>

    <!-- Option 2: jQuery, Popper.js, and Bootstrap JS
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.min.js" integrity="sha384-w1Q4orYjBQndcko6MimVbzY0tgp4pWB4lZ7lr30WKz0vr/aWKhXdBNmNb5D92v7s" crossorigin="anonymous"></script>
    -->
    
    <nav class="navbar navbar-expand-lg navbar-dark bg-primary fixed-top">
      <a class="navbar-brand text-light font-weight-bold" href="index.php">Hobimegel</a>
      <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarText" aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>
      <div class="collapse navbar-collapse" id="navbarText">
        <ul class="navbar-nav mr-auto">
          <li class="nav-item active">
            <a class="nav-link" href="../../index.php">Home <span class="sr-only">(current)</span></a>
            <li class="nav-item">
                <a class="nav-link" href="../../admin.php">Admin</a>
            </li>
            <li class="nav-item dropdown">
              <a class="nav-link dropdown-toggle" href="#" id="navbarDropdownMenuLink" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                Karyawan
              </a>
              <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                <a class="dropdown-item" href="../../datadiri.php">Data diri</a>
                <a class="dropdown-item" href="#">Pendidikan</a>
              </div>
            </li>
            <li class="nav-item dropdown">
              <a class="nav-link dropdown-toggle" href="#" id="navbarDropdownMenuLink" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                Absensi
              </a>
              <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                <a class="dropdown-item" href="#">Absen</a>
                <a class="dropdown-item" href="#">Izin</a>
              </div>
            </li>
        </ul>
        <span class="navbar-text font-weight-bold text-light">
          <?php echo $_SESSION['username']; ?>
          <a href="../../logout.php" class="btn btn-danger btn-sm active" role="button" aria-pressed="true">Logout</a>
        </span>
      </div>
    </nav>

    <!-- edit data karyawan -->
    <div class="container pt-5 pb-5" style="margin-top:2rem;">
        <div class="row justify-content-md-center ">
            <div class="col-md-8">
            <div class="card shadow sm-3 mb-5 bg-white rounded">
                <div class="card-header bg-primary mb-0"><h5 class="text-center text-white">Edit Data <span class="font-weight-bold text-light " >Karyawan</span></h5></div>
                <div class="card-body">
                <?php
                    include_once("../../koneksi.php");
                    if (isset($_GET['NIK'])) {
                        $ubah=$_GET['NIK'];
                    } else {
                        die ("ERROR");
                    }
                    
                    $da = mysqli_query($koneksi,"SELECT * FROM karyawan WHERE NIK='$ubah'");
                    if (isset($_POST['edit'])) {
                        $NIK = $_POST['NIK'];
                        $nama_karyawan = $_POST['nama_karyawan'];
                        $tanggal_lahir = $_POST['tanggal_lahir'];
                        $agama = $_POST['agama'];
                        $jenis_kelamin = $_POST['jenis_kelamin'];
                        $alamat = $_POST['alamat'];
                        $telepon = $_POST['telepon'];
                        $email = $_POST['email'];
                        $kd_jabatan = $_POST['kd_jabatan'];
                        $update_at = $_POST['update_at'];
                            
                        $query="UPDATE karyawan SET NIK = '$NIK', nama_karyawan='$nama_karyawan', tanggal_lahir='$tanggal_lahir', agama='$agama', jenis_kelamin='$jenis_kelamin', alamat='$alamat', telepon='$telepon', email='$email', kd_jabatan='$kd_jabatan', update_at='$update_at' WHERE NIK='$NIK'";
                        $sql=mysqli_query($koneksi,$query);
                        if ($sql) {
                            echo '<script>alert("Berhasil mengedit data."); document.location="../../datadiri.php";</script>';
                        } else {
                        ?>
                        <div class="alert alert-primary text-center text-danger" role="alert">
                            gagal mengapdate data admin
                        </div> 
                        <?php } 
                         

                    }
                    while($dat = mysqli_fetch_assoc($da)){
                        
                ?>
                <form action="" method="post">
                    <div class="form-group">
                        <label for="exampleFormControlSelect1">Nama Karyawan</label>
                        <input type="hidden" name="NIK" class="form-control" value="<?php echo $dat['NIK']; ?>">
                        <textarea name="update_at" style="display:none"><?php echo date("h:i:s d/m/Y ");?></textarea>
                        <input type="text" name="nama_karyawan" class="form-control" value="<?php echo $dat['nama_karyawan']; ?>">
                    </div>
                    <div class="form-group">
                        <label for="exampleFormControlSelect1">Tanggal Lahir</label>
                        <input type="date" name="tanggal_lahir" class="form-control" value="<?php echo $dat['tanggal_lahir']; ?>">
                    </div>
                    <div class="form-group">
                        <label for="exampleFormControlSelect1">Agama</label>
                        <select class="form-control" name="agama" class="form-control">
                            <option><?php echo $dat['agama']; ?></option>
                            <option>Islam</option>
                            <option>Hindu</option>
                            <option>Kristen</option>
                            <option>Budha</option>
                            <option>Konghucu</option>
                        </select>
                    </div>
                    <div class="form-group">
                        <label for="exampleFormControlSelect1">Jenis Kelamin</label>
                        <select class="form-control" name="jenis_kelamin" class="form-control">
                            <option><?php echo $dat['jenis_kelamin']; ?></option>
                            <option>LakiLaki</option>
                            <option>Perempuan</option>
                        </select>
                    </div>
                    <div class="form-group">
                        <label for="exampleFormControlSelect1">Alamat</label>
                        <textarea class="form-control" id="exampleFormControlTextarea1" name="alamat" rows="3"><?php echo $dat['alamat']; ?></textarea>
                    </div>
                    <div class="form-group">
                        <label for="exampleFormControlSelect1">Telepon</label>
                        <input type="number" name="telepon" class="form-control" value="<?php echo $dat['telepon']; ?>">
                    </div>
                    <div class="form-group">
                        <label for="exampleFormControlSelect1">Email</label>
                        <input type="email" name="email" class="form-control" value="<?php echo $dat['email']; ?>">
                    </div>
                    <div class="form-group">
                        <label for="exampleFormControlSelect1">Kode Jabatan</label>
                        <select class="form-control" name="kd_jabatan" class="form-control">
                            <?php
                            $query = "SELECT id_jabatan,jabatan FROM jabatan ORDER BY jabatan";
                            $sql = mysqli_query($koneksi, $query);
                            while ($hasil = mysqli_fetch_assoc($sql)) {
                                $selected = ($hasil['kd_jabatan']==
                                $kd_jabatan) ? "selected" : "";
                                echo "<option value='$hasil[id_jabatan]'$selected>$hasil[jabatan]</option>";
                            }
                            ?>
                        </select>
                    </div>
                    <div class="form-group">
                        <input type="submit" name="edit" value="Simpan" class="btn btn-primary btn-block">
                        <a href="../../datadiri.php" class="btn btn-danger btn-block active" role="button" aria-pressed="true">Batal</a>
                    </div>
                </form>
                <?php }?>
                </div>
            </div>
            </div>
        </div>
    </div>
    
</body>
</html>