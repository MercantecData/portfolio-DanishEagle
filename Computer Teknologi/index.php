<!DOCTYPE html>
<?php
include("auth.php");
?>
<html>
<head>
    <div class="container">
        <link rel="stylesheet" href="stylesheet.css">
        <link href="https://fonts.googleapis.com/css?family=Bad+Script|Marck+Script&display=swap" rel="stylesheet">
        <title>Journal</title>
    </div>
</head>
<body class="bg">
    <div class="container">
        <ul class="navbar">
            <li class="nav"><a href="index.html">Journal</a></li>
            <li class="nav"><a href="entries.html">Entries</a></li>
        </ul>

        <h1>Journal of</h1>
        <h3><?php echo $_SESSION['username']; ?></h3>
        <div class="journal">
            <form>
                <textarea></textarea><br>
                <input name="submit" type="submit" value="Submit" />
            </form>
        </div>
        <a href="logout.php">Logout</a>
    </div>
</body>
<footer>

</footer>
</html>