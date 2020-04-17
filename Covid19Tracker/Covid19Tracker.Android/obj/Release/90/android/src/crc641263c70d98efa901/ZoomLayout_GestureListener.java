package crc641263c70d98efa901;


public class ZoomLayout_GestureListener
	extends android.view.GestureDetector.SimpleOnGestureListener
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDoubleTap:(Landroid/view/MotionEvent;)Z:GetOnDoubleTap_Landroid_view_MotionEvent_Handler\n" +
			"n_onScroll:(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z:GetOnScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFHandler\n" +
			"";
		mono.android.Runtime.register ("Com.Syncfusion.Maps.ZoomLayout+GestureListener, Syncfusion.SfMaps.Android", ZoomLayout_GestureListener.class, __md_methods);
	}


	public ZoomLayout_GestureListener ()
	{
		super ();
		if (getClass () == ZoomLayout_GestureListener.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Maps.ZoomLayout+GestureListener, Syncfusion.SfMaps.Android", "", this, new java.lang.Object[] {  });
	}

	public ZoomLayout_GestureListener (crc641263c70d98efa901.ZoomLayout p0)
	{
		super ();
		if (getClass () == ZoomLayout_GestureListener.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Maps.ZoomLayout+GestureListener, Syncfusion.SfMaps.Android", "Com.Syncfusion.Maps.ZoomLayout, Syncfusion.SfMaps.Android", this, new java.lang.Object[] { p0 });
	}


	public boolean onDoubleTap (android.view.MotionEvent p0)
	{
		return n_onDoubleTap (p0);
	}

	private native boolean n_onDoubleTap (android.view.MotionEvent p0);


	public boolean onScroll (android.view.MotionEvent p0, android.view.MotionEvent p1, float p2, float p3)
	{
		return n_onScroll (p0, p1, p2, p3);
	}

	private native boolean n_onScroll (android.view.MotionEvent p0, android.view.MotionEvent p1, float p2, float p3);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
