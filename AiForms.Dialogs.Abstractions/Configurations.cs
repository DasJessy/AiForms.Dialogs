﻿using System;
namespace AiForms.Dialogs.Abstractions
{
    public static class Configurations
    {
        static LoadingConfig _LoadingConfig;

        public static LoadingConfig LoadingConfig
        {
            get { return _LoadingConfig = _LoadingConfig ?? new LoadingConfig(); }
            set { _LoadingConfig = value; }
        }
    }
}
