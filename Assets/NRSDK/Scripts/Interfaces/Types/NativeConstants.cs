﻿/****************************************************************************
* Copyright 2019 Nreal Techonology Limited. All rights reserved.
*                                                                                                                                                          
* This file is part of NRSDK.                                                                                                          
*                                                                                                                                                           
* https://www.nreal.ai/        
* 
*****************************************************************************/

namespace NRKernal
{
    using System;

    public class NativeConstants
    {
        public const UInt64 NRHANDLENULL = 0;

        public const UInt32 IllegalInt = 0;

#if  UNITY_EDITOR
        public const string NRNativeLibrary = "libnr_api_editor";
#elif UNITY_STANDALONE_WIN
        public const string NRNativeLibrary = "libnr_api";
#else
        public const string NRNativeLibrary = "nr_api";
#endif


#if UNITY_EDITOR_OSX
        public static string TrackingImageCliBinary = "trackableImageTools_osx";
#elif UNITY_EDITOR_WIN
        public static string TrackingImageCliBinary = "trackableImageTools_win";
#elif UNITY_EDITOR_LINUX
        public static string TrackingImageCliBinary = "trackableImageTools_linux";
#endif

        public static string ZipKey = "89f55314-6d41-416c-b4d9-4bdbc155e576";

        public static string GlassesDisconnectErrorTip = "Glasses connect error. Please connect the device correctly.";
        public static string SdkVersionMismatchErrorTip = "The NRSDK version does not match. Please update to the latest version of the service.";
        public static string SdcardPermissionDenyErrorTip = "There is no write permission for sdcard. Please go to the authorization management page of the device to authorize.";
        public static string UnknowErrorTip = "Unkown error. Please contact nreal's after sales team.";
    }
}
