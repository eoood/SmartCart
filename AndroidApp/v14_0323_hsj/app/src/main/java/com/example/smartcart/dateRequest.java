package com.example.smartcart;

import androidx.annotation.Nullable;

import com.android.volley.AuthFailureError;
import com.android.volley.Response;
import com.android.volley.toolbox.StringRequest;

import java.util.HashMap;
import java.util.Map;

import static com.android.volley.Request.Method.POST;

public class dateRequest extends StringRequest {

    final static private  String URL = "http://192.168.0.201/buydateList.php";
    private Map<String, String> map;

    public dateRequest(String date, Response.Listener<String>listener) {
        super(Method.POST ,URL, listener, null);

        map = new HashMap<>();
        map.put("date",date);
    }
    @Override
    protected Map<String, String> getParams() throws AuthFailureError{
        return map;
    }
}
