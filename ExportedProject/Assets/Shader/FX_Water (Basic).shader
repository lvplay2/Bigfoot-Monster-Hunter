Shader "FX/Water (Basic)" {
	Properties {
		_horizonColor ("Horizon color", Color) = (0.172,0.463,0.435,0)
		_WaveScale ("Wave scale", Range(0.02, 0.15)) = 0.07
		[NoScaleOffset] _ColorControl ("Reflective color (RGB) fresnel (A) ", 2D) = "" {}
		[NoScaleOffset] _BumpMap ("Waves Normalmap ", 2D) = "" {}
		WaveSpeed ("Wave speed (map1 x,y; map2 x,y)", Vector) = (19,9,-16,-7)
	}
	SubShader {
		Tags { "RenderType" = "Opaque" }
		Pass {
			Tags { "RenderType" = "Opaque" }
			GpuProgramID 59198
			// No subprograms found
		}
	}
}