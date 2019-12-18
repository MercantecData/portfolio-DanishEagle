<?php
require('db.php');
include("auth.php");
?>
<!DOCTYPE html>
<html>
<head>
    <div class="container">
        <link rel="stylesheet" href="stylesheet.css">
        <link href="https://fonts.googleapis.com/css?family=Bad+Script|Marck+Script&display=swap" rel="stylesheet">
        <title>Journal</title>
    </div>
</head>
<body class="bg">

    <?php
        if(isset($_POST['submit']))
            {
            $entry = $_POST['entry'];

            $query = ("INSERT INTO `entries` (entry) VALUES ('$entry')");
            $result = mysqli_query($con,$query);
        
            } 
    ?>

    <div class="container">
        <ul class="navbar">
            <li class="nav"><a href="index.php">Journal</a></li>
            <li class="nav"><a href="entries.php">Entries</a></li>
        </ul>

        <h1>Journal of</h1>
        <h2><?php echo $_SESSION['username']; ?></h2>
        <div class="journal">
            <form action="" method="post">
                <textarea name="entry"></textarea><br>
                <input name="submit" type="submit" value="Submit" />
            </form>
            </div>
            <a href="logout.php">Logout</a>  
    </div>
</body>
<footer>

</footer>
</html>