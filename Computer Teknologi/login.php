<!DOCTYPE html>
<html>
<head>
    <div class="container">
        <link rel="stylesheet" href="stylesheet.css"/>
        <link href="https://fonts.googleapis.com/css?family=Bad+Script|Marck+Script&display=swap" rel="stylesheet"/>
        <title>Login</title>
    </div>
</head>
<body class="bg">
<?php 
require('db.php');
session_start();
//if form is submitted, insert values into the database 
if (isset($_POST['username'])){
    // removes backslashes
    $username = stripslashes($_REQUEST['username']);
    //escapes special characters in a string
    $username = mysqli_real_escape_string($con,$username);
    $password = stripslashes($_REQUEST['password']);
    $password = mysqli_real_escape_string($con,$password);
        //checking if user already exists in database 
        $query = "SELECT * FROM `users` WHERE username='$username' and password='".md5($password)."'";
        $result = mysqli_query($con,$query) or die(mysql_error());
        $rows = mysqli_num_rows($result);
        if($rows==1){
            $_SESSION['username'] = $username;
            // Redirect user to index.php
            header("Location: index.php");
            }else{
        echo "<div class='form'>
        <h3>Username/password is incorrect.</h3>
        <br/><p>Try to log in again <a href='login.php'>here</a></p>
        </div>";
        }
    }else{
?>
    <div class="container">
    <div class="form">
        <h1>Log In</h1>
        <form action="" method="post" name="login">
        <input type="text" name="username" placeholder="Username" required/><br>
        <input type="password" name="password" placeholder="Password" required/><br>
        <input name="submit" type="submit" value="Login" />
        </form>

        <p>Not registered yet? Create an account <a href="registration.php">here</a></p>
    </div>
    <?php } ?>
    </div>
</body>
</html>