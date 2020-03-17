<?php

 $con = mysqli_connect("localhost","oaoopw","kara1136!","oaoopw");
 $result = mysqli_query($con,"SELECT SUM(price) FROM ORDER2 where buyday;");

 $response = array();

 while($row = mysqli_fetch_array($result)){
	
 array_push($response,array("SUM"=>$row[0]));

 }
 
 echo json_encode(array("response" =>$response));

 mysqli_close($con);

?>