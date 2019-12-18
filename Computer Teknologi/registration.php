<!DOCTYPE html>
<html>
<head>
    <div class="container">
        <link rel="stylesheet" href="stylesheet.css"/>
        <link href="https://fonts.googleapis.com/css?family=Bad+Script|Marck+Script&display=swap" rel="stylesheet"/>
        <title>Registration</title>
    </div>
</head>
<body class="bg">
    <div class="container">
<?php 
require('db.php');
if (isset($_REQUEST['username'])){
        //removes backslashes
    $username = stripslashes($_REQUEST['username']);
        //escapes special characters in a string
    $username = mysqli_real_escape_string($con,$username);
    $password = stripslashes($_REQUEST['password']);
    $password = mysqli_real_escape_string($con,$password);
        $query = "INSERT into `users` (username, password) VALUES ('$username', '".md5($password)."')";
        $result = mysqli_query($con,$query);
        if($result) {
            echo "<div class='form'>
            <h3>You have been registered successfully.</h3>
            <br/><p>Click here to <a href='login.php'>Login</a></p>
            </div>";
        }
} else {
?>
<div class="form">
    <h1>Registration</h1>

    <form name="registration" action="" method="post">
    <input type="text" name="username" placeholder="Username" required/><br>
    <input type="password" name="password" placeholder="Password" required/><br>
    <input name="submit" type="submit" value="Register" />
    </form>
    <p>Already got an account? Login <a href="login.php">here</a></p>
</div>
<?php } ?>
</div>
</body>
<footer>

</footer>
</html>