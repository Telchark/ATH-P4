﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace MapDemo.UI.Wrapper
{
    public class ModelWrapper<T> : NotifyDataErrorInfoBase
    {
        public ModelWrapper(T model)
        {
            Model = model;
        }
        public T Model { get; }
        protected virtual void SetValue<TValue>(TValue value, [CallerMemberName]string propertyName = null)
        {
            typeof(T).GetProperty(propertyName).SetValue(Model,value);
            OnPropertyChanged(propertyName);
            ClearErrors(propertyName);
            ValidateDataAnnotations(propertyName, value);
        }
        protected virtual TValue GetValue<TValue>([CallerMemberName]string propertyName = null)
        {
            return (TValue)typeof(T).GetProperty(propertyName).GetValue(Model);
        }
        private void ValidateDataAnnotations(string propertyName, object currentValue)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(Model) { MemberName = propertyName };
            Validator.TryValidateProperty(currentValue, context, results);
            foreach (var result in results)
            {
                AddError(propertyName, result.ErrorMessage);
            }
        }

    }
}
