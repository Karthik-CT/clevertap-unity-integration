using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CleverTap;
using CleverTap.Utilities;

public class ButtonHandler : MonoBehaviour
{
    // Start is called before the first frame update
    
	public void pushEvent() {
		CleverTapBinding.RecordEvent("ProductUni Viewed");
	}
	
	public void pushNotification() {
		CleverTapBinding.RecordEvent("Karthiks Noti Event");
	}
	
	public void inApp() {
		CleverTapBinding.RecordEvent("Karthiks InApp Event");
	}
	
	public void appInbox() {
		CleverTapBinding.RecordEvent("Karthiks App Inbox Event");
	}
	
}
