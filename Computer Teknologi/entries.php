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
        <title>Entries</title>
    </div>
</head>
<body class="bg">
    <div class="container">
        <ul class="navbar">
            <li class="nav"><a href="index.php">Journal</a></li>
            <li class="nav"><a href="entries.php">Entries</a></li>
        </ul>
        <h1>Entries of</h1>
        <h2><?php echo $_SESSION['username']; ?></h2> 
    <?php
    $sql = "SELECT entry FROM `entries`";
    $result = mysqli_query($sql); 

    echo "<table border='1'>";
    echo "<tr><td>Entry</td></tr>\n";
    while($row = mysqli_fetch_assoc($result)) {
        echo "<tr><td>{$row['Entry']}</td></tr>\n";
    }
    echo "</table";
    ?>
        <a href="logout.php">Logout</a>
    </div>
</body>
<footer>

</footer>
</html>