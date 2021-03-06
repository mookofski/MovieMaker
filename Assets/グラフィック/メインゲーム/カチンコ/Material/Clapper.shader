Shader "Unlit/Clapper"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _time ("Time", float) = 0.0
        _Slider ("Slider", Range(0,1)) = 1.0
        _Repeat ("Repeat", float) = 1.0


    }
    SubShader
    {
        Tags { "QUEUE"="Transparent" "IGNOREPROJECTOR"="true" "RenderType"="Transparent" "CanUseSpriteAtlas"="true" "PreviewType"="Plane" }
        LOD 100
        Cull Off
        Lighting Off
        ZTest [unity_GUIZTestMode]
        Blend SrcAlpha OneMinusSrcAlpha
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            // make fog work
            #pragma multi_compile_fog

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                UNITY_FOG_COORDS(1)
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
            float _Repeat;
            float _time;
            float _Slider;
            
            ;
            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                UNITY_TRANSFER_FOG(o,o.vertex);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                // sample the texture
                float2 os=i.uv;
                os.x/=_Repeat;
                os.x=fmod(_time+os.x,1.0f);
                fixed4 col = tex2D(_MainTex, os);
                // apply fog
                UNITY_APPLY_FOG(i.fogCoord, col);
               
                return col*(i.uv.x<_Slider);
            }
            ENDCG
        }
    }
}
