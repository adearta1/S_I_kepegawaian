<!DOCTYPE html>
<html lang="en" style="scroll-behavior: smooth;">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous">
</head>
<body>
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
        <a class="ml-5 navbar-brand text-light font-weight-bold" href="#">
            <img src="database/gambar/hobimegel.png" width="30" height="30" class="d-inline-block align-top" alt="" loading="lazy">
            Hobimegel
        </a>
        <div class="collapse navbar-collapse" id="navbarText">
            <ul class="navbar-nav mr-auto">
                <li class="nav-item active">
                    <a class="nav-link font-weight-bold " href="#">Home <span class="sr-only">(current)</span></a>
                </li>
                <li class="nav-item">
                    <a class="nav-link font-weight-bold" href="#absen">Absensi</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link font-weight-bold" href="#izin">Izin</a>
                </li>
            </ul>
        </div>
    </nav>
    <div class="container">
        <div class="container pt-2 pb-2 bg-primary-50 shadow-none p-3 mb-5 bg-white rounded">
            <div class="jumbotron jumbotron-fluid">
                <div class="container text-center">
                    <img src="database/gambar/hobimegel.png" alt="" width="200" class="rounded-circle">
                    <h1 class="display-4">HOBI MEGEL</h1>
                    <p class="lead font-weight-bold">selamat datang dan silahkan melakukan</p>
                    <hr class="my-4">
                    <a href="#absen" class="btn btn-primary btn-md active" role="button" aria-pressed="true">Absensi</a>
                    <a href="#izin" class="btn btn-primary btn-md active" role="button" aria-pressed="true">Izin</a>
                </div>
            </div> 
        </div>
    
        <div class="container shadow sm-3 mb-5 bg-white rounded" style="padding-top: 12rem; padding-bottom: 12rem;" id="absen">
            <div class="row justify-content-md-center ">
            <div class="col-md-7">
            <div class="card">
                <div class="card-header bg-primary mb-0"><h5 class="text-center text-white"> <span class="font-weight-bold text-light " >Absensi</span></h5></div>
                <div class="card-body">
                <form action="absen.php" method="post">
                    <div class="form-group">
                        <textarea name="tanggal" style="display:none"><?php echo date("h:i:s d/m/Y ");?></textarea>
                        <input type="text" name="NIK" class="form-control" placeholder="Masukkan NIK anda">
                    </div>
                    <div class="form-group">
                        <select name="keterangan" class="form-control">
                            <option>Hadir</option>
                            <option>Tidak Hadir</option>
                        </select>
                    </div>
                    <div class="form-group">
                    <input type="submit" name="submit" value="Submit" class="btn btn-primary btn-block">
                    </div>
                </form>
                </div>
            </div>
            </div>
            </div>
        </div>
        <div class="container shadow sm-3 mb-5 bg-white rounded" style="padding-top: 12rem; padding-bottom: 12rem;" id="izin">
            <div class="row justify-content-md-center ">
            <div class="col-md-7">
            <div class="card">
                <div class="card-header bg-primary mb-0"><h5 class="text-center text-white"> <span class="font-weight-bold text-light " >Izin</span></h5></div>
                <div class="card-body">
                <form action="izin.php" method="post">
                    <div class="form-group">
                        <textarea name="created_at" style="display:none"><?php echo date("h:i:s d/m/Y ");?></textarea>
                        <input type="text" name="NIK" class="form-control" placeholder="Masukkan NIK anda">
                    </div>
                    <div class="form-group">
                        <textarea name="keterangan" class="form-control" id="exampleFormControlTextarea1" rows="3" placeholder="Masukkan keterangan anda"></textarea>
                    </div class="form-group">
                    <label for="exampleFormControlSelect1">Izin dari tanggal</label>
                        <input type="date" name="izin_tanggal" class="form-control" >
                        <label for="exampleFormControlSelect1">Izin sampai tanggal</label>
                        <input type="date" name="sampai_tanggal" class="form-control">
                    </div>
                    <div class="form-group">
                        <input type="submit" name="submit" value="Submit" class="btn btn-primary btn-block">
                    </div>
                </form>
                </div>
            </div>
            </div>
            </div>
        </div>
    </div>
</body>
</html>