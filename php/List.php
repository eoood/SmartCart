<?php

    $con = mysqli_connect("localhost", "root", "apmsetup", "smartcart");
    $result = mysqli_query($con, "SELECT * FROM USER;");

    $response = array();//배열 선언

    while($row = mysqli_fetch_array($result)){
    //response["userID"]=$row[0] ....이런식으로 됨.

    array_push($response, array("userName"=>$row[0], "useID"=>$row[1], "userPassword"=>$row[2], "userMail"=>$row[3] ));
    }
    //response라는 변수명으로 JSON 타입으로 $response 내용을 출력

    echo json_encode(array("response"=>$response));

    mysqli_close($con);
?>
