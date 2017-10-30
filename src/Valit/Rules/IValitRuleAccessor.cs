﻿using System;
using Valit.Errors;

namespace Valit.Rules
{
    internal interface IValitRuleAccessor
    {
        IValitStrategy Strategy { get; }
        IValitMessageProvider GetMessageProvider();
        IValitMessageProvider<TKey> GetMessageProvider<TKey>();
        void AddError(ValitRuleError error);
        void AddTags(params string[] tags);
    }
    
    internal interface IValitRuleAccessor<TObject, TProperty> : IValitRuleAccessor where TObject : class
    {
        Func<TObject, TProperty> PropertySelector { get; }
        IValitRule<TObject, TProperty> PreviousRule { get; }
        void SetPredicate(Predicate<TProperty> predicate);     
        void AddCondition(Predicate<TObject> condition);        
    }
}
