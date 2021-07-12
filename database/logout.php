<?php 
// mengaktifkan session
session_start();
 
// menghapus semua session
session_destroy();
if (isset($_POST['status'])){
    setcookie('status',time()-3600);
}
// mengalihkan halaman sambil mengirim pesan logout
header("location:../login.php?pesan=logout");
?>