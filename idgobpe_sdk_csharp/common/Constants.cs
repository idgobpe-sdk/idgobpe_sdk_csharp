﻿using System;

/**
 * @author Miguel Pazo (http://miguelpazo.com)
 */
namespace idgobpe_sdk_csharp.common
{
    public class Constants
    {
        //ACR
        public static String ACR_ONE_FACTOR = "one_factor";
        public static String ACR_TWO_FACTOR = "two_factor";
        public static String ACR_CERTIFICATE_DNIE = "certificate_dnie";
        public static String ACR_CERTIFICATE_TOKEN = "certificate_token";
        public static String ACR_CERTIFICATE_DNIE_LEGACY = "certificate_dnie_legacy";
        public static String ACR_CERTIFICATE_TOKEN_LEGACY = "certificate_token_legacy";

        //PROMPT
        public static String PROMPT_NONE = "none";
        public static String PROMPT_LOGIN = "login";
        public static String PROMPT_CONSENT = "consent";

        //SCOPE
        public static String SCOPE_PROFILE = "profile";
        public static String SCOPE_EMAIL = "email";
        public static String SCOPE_PHONE = "phone";
        public static String SCOPE_OFFLINE_ACCESS = "offline_access";
    }
}
