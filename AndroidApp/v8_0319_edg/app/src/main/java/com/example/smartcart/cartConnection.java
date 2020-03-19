package com.example.smartcart;

import android.content.DialogInterface;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

public class cartConnection extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_cart_connection);

        Button button1 = (Button)findViewById(R.id.cart_btn1);
        button1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                show1();
            }
        });
    }

    void show1()
    {
        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        builder.setTitle("카트 연결");
        builder.setMessage("1번 카트를 연결하시겠습니까?");
        builder.setPositiveButton("예",
                new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialog, int which) {
                        Toast.makeText(getApplicationContext(),"1번 카트와 연결하였습니다.",Toast.LENGTH_LONG).show();
                    }
                });
        builder.setNegativeButton("아니오",
                new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialog, int which) {
                        Toast.makeText(getApplicationContext(),"1번 카트를 취소하였습니다.",Toast.LENGTH_LONG).show();
                    }
                });
        builder.show();
    }

}
