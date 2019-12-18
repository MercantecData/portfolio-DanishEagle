<?php
session_start();
//Destroy all sessions 

if(session_destroy())
{
    //redirect to home page 
    header("Location: login.php");
}
?>