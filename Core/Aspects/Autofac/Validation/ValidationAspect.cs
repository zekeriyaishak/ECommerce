using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception //Aspect- methodun basında sonunda hata verdiğinde çalışacak yapı
                                                       
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            //IsAssignable - atanabiliyor mu yani validator atanması lazım
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Bu bir doğrulama sınıfı değil");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            //Reflection-çalışma anında instance üretiyor.
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0]; //product tipi
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType); //methodun argumanlarını gez ordaki tip benım entty tipime eşitse validate et
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
