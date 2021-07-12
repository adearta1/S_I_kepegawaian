<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous">
    <title>Document</title>
</head>
<body class="text-center" style="background-color: rgb(64, 99, 255);">
    <!-- Optional JavaScript; choose one of the two! -->

    <!-- Option 1: jQuery and Bootstrap Bundle (includes Popper) -->
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ho+j7jyWK8fNQe+A12Hb8AhRq26LrZ/JpcUGGOn+Y7RsweNrtN/tE3MoK7ZeZDyx" crossorigin="anonymous"></script>

    <!-- Option 2: jQuery, Popper.js, and Bootstrap JS
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.min.js" integrity="sha384-w1Q4orYjBQndcko6MimVbzY0tgp4pWB4lZ7lr30WKz0vr/aWKhXdBNmNb5D92v7s" crossorigin="anonymous"></script>
    -->
    
    <div class="container" style="margin-top : 10rem;">
        <div class="row justify-content-md-center ">
            <div class="col-md-4">
            <div class="card">
                <div class="card-header bg-primary mb-0"><h5 class="text-center text-white">Edit Data <span class="font-weight-bold text-light " >Admin</span></h5></div>
                <div class="card-body">
                <?php
                    include_once("../../koneksi.php");
                    if (isset($_GET['id_admin'])) {
                        $ubah=$_GET['id_admin'];
                    } else {
                        die ("ERROR");
                    }
                    
                    $da = mysqli_query($koneksi,"SELECT * FROM admin WHERE id_admin='$ubah'");
                    if (isset($_POST['edit'])) {
                        $id = $_POST['id_admin'];
                        $nama = $_POST['nama'];
                        $username = $_POST['username'];
                        $password = $_POST['password'];
                            
                        $query="UPDATE admin SET id_admin = '$id', username='$username',password='$password',nama='$nama' WHERE id_admin='$id'";
                        $sql=mysqli_query($koneksi,$query);
                        if ($sql) {
                            header("location:../../admin.php");
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
                        <label for="exampleFormControlSelect1">Nama</label>
                        <input type="hidden" name="id_admin" class="form-control" value="<?php echo $dat['id_admin']; ?>">
                        <input type="text" name="nama" class="form-control" value="<?php echo $dat['nama']; ?>">
                    </div>
                    <div class="form-group">
                        <label for="exampleFormControlSelect1">Username</label>
                        <input type="text" name="username" class="form-control" value="<?php echo $dat['username']; ?>">
                    </div>
                    <div class="form-group">
                        <label for="exampleFormControlSelect1">Password</label>
                        <input type="text" name="password" class="form-control" value="<?php echo $dat['password']; ?>">
                    </div>
                    <div class="form-group">
                        <input type="submit" name="edit" value="Simpan" class="btn btn-primary btn-block">
                        <a href="admin.php" class="btn btn-danger btn-block active" role="button" aria-pressed="true">Batal</a>
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