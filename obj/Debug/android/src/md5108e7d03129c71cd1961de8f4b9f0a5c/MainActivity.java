package md5108e7d03129c71cd1961de8f4b9f0a5c;


public class MainActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_clicking:(Landroid/view/View;)V:__export__\n" +
			"n_CloseWindow:(Landroid/view/View;)V:__export__\n" +
			"";
		mono.android.Runtime.register ("testapp.MainActivity, testapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MainActivity.class, __md_methods);
	}


	public MainActivity ()
	{
		super ();
		if (getClass () == MainActivity.class)
			mono.android.TypeManager.Activate ("testapp.MainActivity, testapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void clicking (android.view.View p0)
	{
		n_clicking (p0);
	}

	private native void n_clicking (android.view.View p0);


	public void CloseWindow (android.view.View p0)
	{
		n_CloseWindow (p0);
	}

	private native void n_CloseWindow (android.view.View p0);

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
