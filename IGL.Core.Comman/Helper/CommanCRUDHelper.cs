﻿using System;
using System.Reflection;

namespace IGL.Core.Comman.Helper
{
    public static class CommanCRUDHelper
    {
        public static T CommanCreateCode<T>(T entity, int userId)
        {

            Type modelType = entity.GetType();
            PropertyInfo[] pinfos = modelType.GetProperties();
            foreach (var prop in pinfos)
            {
                if (prop.Name == "SessionId")
                {
                    prop.SetValue(entity, userId);
                }
            }
            return entity;
        }

        public static T CommanDeleteCode<T>(T entity, int userId)
        {

            Type modelType = entity.GetType();
            PropertyInfo[] pinfos = modelType.GetProperties();
            foreach (var prop in pinfos)
            {
                if (prop.Name == "IsDeleted")
                {
                    prop.SetValue(entity, 1, null);
                }
                else if (prop.Name == "IsActive")
                {
                    prop.SetValue(entity, 0, null);
                }
                else if (prop.Name == "UpdatedBy")
                {
                    prop.SetValue(entity, userId, null);
                }
                else if (prop.Name == "UpdatedDate")
                {
                    prop.SetValue(entity, DateTime.Now.Date, null);
                }
                else if (prop.Name == "SessionId")
                {
                    prop.SetValue(entity, userId);
                }
            }
            return entity;
        }

        public static T CommanUpdateCode<T>(T entity, int userId)
        {
            Type modelType = entity.GetType();
            PropertyInfo[] pinfos = modelType.GetProperties();
            foreach (var prop in pinfos)
            {

                if (prop.Name == "UpdatedBy")
                {
                    prop.SetValue(entity, userId, null);
                }
                else if (prop.Name == "UpdatedDate")
                {
                    prop.SetValue(entity, DateTime.Now.Date, null);
                }
                else if (prop.Name == "SessionId")
                {
                    prop.SetValue(entity, userId);
                }
            }
            return entity;
        }
    }
}
