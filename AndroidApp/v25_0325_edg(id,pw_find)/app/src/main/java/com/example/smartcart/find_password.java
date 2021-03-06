package com.example.smartcart;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageButton;

import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.toolbox.Volley;

import org.json.JSONObject;

public class find_password extends AppCompatActivity {

    private ImageButton btn_back;
    private EditText find_pw_id, find_pw_name, find_pw_mail;
    private Button btn_find_pw;
    private AlertDialog dialog;
    private boolean validate = false;   //정보가 일치한지 체크해주는 변수

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_find_password);

        //뒤로가기
        btn_back = findViewById(R.id.backspace2);
        btn_back.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(find_password.this, LoginActivity.class);
                startActivity(intent);
            }
        });



        //초기화
        find_pw_id = findViewById(R.id.find_pw_id);
        find_pw_name = findViewById(R.id.find_pw_name);
        find_pw_mail = findViewById(R.id.find_pw_mail);

        //확인 버튼 클릭
        btn_find_pw = findViewById(R.id.btn_find_pw);
        btn_find_pw.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                //EditText에 입력된 값을 가져옴
                final String userID = find_pw_id.getText().toString();
                final String userName = find_pw_name.getText().toString();
                final String userMail = find_pw_mail.getText().toString();
                Log.d("Response", "find_pw --> userID:  " + userID);
                Log.d("Response", "find_pw --> userName:  " + userName);
                Log.d("Response", "find_pw --> userMail:  " + userMail);

                if (userID.equals("")) {
                    AlertDialog.Builder builder = new AlertDialog.Builder(find_password.this);
                    dialog = builder.setMessage("아이디가 빈칸입니다.")
                            .setPositiveButton("확인", null)
                            .create();
                    dialog.show();
                    return;
                }

                if (userName.equals("")) {
                    AlertDialog.Builder builder = new AlertDialog.Builder(find_password.this);
                    dialog = builder.setMessage("이름이 빈칸입니다.")
                            .setPositiveButton("확인", null)
                            .create();
                    dialog.show();
                    return;
                }

                if (userMail.equals("")) {
                    AlertDialog.Builder builder1 = new AlertDialog.Builder(find_password.this);
                    dialog = builder1.setMessage("메일이 빈칸입니다.")
                            .setPositiveButton("확인", null)
                            .create();
                    dialog.show();
                    return;
                }

                //4. 콜백 처리부분(volley 사용을 위한 ResponseListener 구현 부분)
                Response.Listener<String> responseListener = new Response.Listener<String>() {

                    //서버로부터 여기서 데이터를 받음
                    @Override
                    public void onResponse(String response) {

                        try {

                            //서버로부터 받는 데이터는 JSON타입의 객체이다.
                            Log.d("Response", "Response: " + response);
                            JSONObject jsonObject = new JSONObject(response);

                            //그중 Key값이 "success"인 것을 가져온다.
                            boolean success = jsonObject.getBoolean("success");
                            Log.d("Response", "Response: " + success);

                            if (success) {

                                String userPassword = jsonObject.getString("userPassword");
                                Intent intent = new Intent(find_password.this, find_password_result.class);
                                intent.putExtra("userName", userName);
                                intent.putExtra("userPassword", userPassword);
                                startActivity(intent);

                            } else {

                                AlertDialog.Builder builder = new AlertDialog.Builder(find_password.this);
                                dialog = builder.setMessage("입력하신 정보와 일치하는 정보가없습니다.")
                                        .setNegativeButton("확인", null)
                                        .create();
                                dialog.show();
                            }


                        } catch (Exception e) {
                            e.printStackTrace();
                        }


                    }
                };

                //서버로 Volley를 이용해서 요청을 함
                FindRequest2 findRequest2 = new FindRequest2(userID, userName, userMail, responseListener);
                RequestQueue queue = Volley.newRequestQueue(find_password.this);
                queue.add(findRequest2);


            }

        });

    }
}
