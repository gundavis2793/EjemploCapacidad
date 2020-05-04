using System;
using System.Collections.Generic;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V4.App;
using Android.Util;
using App_Utb.Data;
using App_Utb.Droid;
using App_Utb.Helpers;
using App_Utb.Modelos;
using Firebase.Messaging;

namespace App_Utb.Droid
{
    [Service]
    [IntentFilter(new[] { "com.google.firebase.MESSAGING_EVENT" })]
    public class MyFirebaseMessagingService : FirebaseMessagingService
    {
        
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        public MyFirebaseMessagingService()
        {

        }
        public NotificacionDatabase data = new NotificacionDatabase(App.FilePath);
        //public async override void OnMessageReceived(RemoteMessage message)
        //{
        //    base.OnMessageReceived(message);
        //    List<Notificacion> ele = new List<Notificacion>();
        //    ele = await firebaseHelper.GetAllNotificaciones();
        //    new NotificationHelper().CreateNotification(ele[0].titulo, ele[0].mensaje);
        //}
        public async override void OnMessageReceived(RemoteMessage message)
        {
            Notificacion not = new Notificacion();
            base.OnMessageReceived(message);
            List<Notificacion> ele = new List<Notificacion>();

            ele = await firebaseHelper.GetAllNotificaciones();
            string[] eles = message.From.Split("/".ToCharArray());
            not = await firebaseHelper.GetUsuario(eles[2]);
            data.InsertNoti(not);

            new NotificationHelper().CreateNotification(not.titulo, not.mensaje);
        }
    }
}