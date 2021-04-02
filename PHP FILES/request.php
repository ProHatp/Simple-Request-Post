<?php

    if(strlen(strstr($_SERVER['HTTP_USER_AGENT'],"userAgendCode")) <= 0 )
        return;

    $getrequest1    =  $_POST['getrequest1'];
    $getrequest2    =  $_POST['getrequest2'];


    if($getrequest1 == "ProHat")
        echo "Request 01 -> sucess\n";
    else
        echo "Request 01 -> error\n";
    

    if($getrequest2 == "ProHat2")
        echo "Request 02 -> sucess\n";
    else
        echo "Request 02 -> error\n";
    
?>