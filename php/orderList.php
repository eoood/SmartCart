<?php

 $con = mysqli_connect("localhost", "root", "apmsetup", "smartcart");
 $result = mysqli_query($con, "SELECT * FROM ORDER2;");

 $response = array();

 while($row = mysqli_fetch_array($result)){
	
 array_push($response,array("price"=>$row[2],"buyday"=>$row[3]));

 }
 
 echo json_encode(array("response" =>$response));

 mysqli_close($con);

?>