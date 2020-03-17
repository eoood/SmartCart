<?php

 $con = mysqli_connect("localhost", "root", "apmsetup", "smartcart");
 $result = mysqli_query($con,"SUM(price) FROM ORDER2 where buyday = '2020-03-16';");

 $response = array();

array_push($response,array($result));

 echo json_encode(array("response" =>$response));
 mysqli_close($con);

?>