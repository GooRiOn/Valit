namespace Valit
{
    public static class ValitRuleUInt16Extensions
    {
        public static IValitRule<TObject, ushort> IsGreaterThan<TObject>(this IValitRule<TObject, ushort> rule, ushort value) where TObject : class
            => rule.Satisfies(p => p > value);

        public static IValitRule<TObject, ushort> IsGreaterThan<TObject>(this IValitRule<TObject, ushort> rule, ushort? value) where TObject : class
            => rule.Satisfies(p => value.HasValue && p > value.Value);


        public static IValitRule<TObject, ushort?> IsGreaterThan<TObject>(this IValitRule<TObject, ushort?> rule, ushort value) where TObject : class
            => rule.Satisfies(p => p.HasValue && p.Value > value);

        public static IValitRule<TObject, ushort?> IsGreaterThan<TObject>(this IValitRule<TObject, ushort?> rule, ushort? value) where TObject : class
            => rule.Satisfies(p => p.HasValue && value.HasValue && p.Value > value.Value);


        public static IValitRule<TObject, ushort> IsLessThan<TObject>(this IValitRule<TObject, ushort> rule, ushort value) where TObject : class
            => rule.Satisfies(p => p < value);

        public static IValitRule<TObject, ushort> IsLessThan<TObject>(this IValitRule<TObject, ushort> rule, ushort? value) where TObject : class
            => rule.Satisfies(p => value.HasValue && p < value.Value);


        public static IValitRule<TObject, ushort?> IsLessThan<TObject>(this IValitRule<TObject, ushort?> rule, ushort value) where TObject : class
            => rule.Satisfies(p => p.HasValue && p.Value < value);

        public static IValitRule<TObject, ushort?> IsLessThan<TObject>(this IValitRule<TObject, ushort?> rule, ushort? value) where TObject : class
            => rule.Satisfies(p => p.HasValue && value.HasValue && p.Value < value.Value);


        public static IValitRule<TObject, ushort> IsGreaterThanOrEqualTo<TObject>(this IValitRule<TObject, ushort> rule, ushort value) where TObject : class
            => rule.Satisfies(p => p >= value);

        public static IValitRule<TObject, ushort> IsGreaterThanOrEqualTo<TObject>(this IValitRule<TObject, ushort> rule, ushort? value) where TObject : class
            => rule.Satisfies(p => value.HasValue && p >= value.Value);


        public static IValitRule<TObject, ushort?> IsGreaterThanOrEqualTo<TObject>(this IValitRule<TObject, ushort?> rule, ushort value) where TObject : class
            => rule.Satisfies(p => p.HasValue && p.Value >= value);

        public static IValitRule<TObject, ushort?> IsGreaterThanOrEqualTo<TObject>(this IValitRule<TObject, ushort?> rule, ushort? value) where TObject : class
            => rule.Satisfies(p => p.HasValue && value.HasValue && p.Value >= value.Value);


        public static IValitRule<TObject, ushort> IsLessThanOrEqualTo<TObject>(this IValitRule<TObject, ushort> rule, ushort value) where TObject : class
            => rule.Satisfies(p => p <= value);

        public static IValitRule<TObject, ushort> IsLessThanOrEqualTo<TObject>(this IValitRule<TObject, ushort> rule, ushort? value) where TObject : class
            => rule.Satisfies(p => value.HasValue && p <= value.Value);


        public static IValitRule<TObject, ushort?> IsLessThanOrEqualTo<TObject>(this IValitRule<TObject, ushort?> rule, ushort value) where TObject : class
            => rule.Satisfies(p => p.HasValue && p.Value <= value);

        public static IValitRule<TObject, ushort?> IsLessThanOrEqualTo<TObject>(this IValitRule<TObject, ushort?> rule, ushort? value) where TObject : class
            => rule.Satisfies(p => p.HasValue && value.HasValue && p.Value <= value.Value);


        public static IValitRule<TObject, ushort> IsEqualTo<TObject>(this IValitRule<TObject, ushort> rule, ushort value) where TObject : class
            => rule.Satisfies(p => p == value);

        public static IValitRule<TObject, ushort> IsEqualTo<TObject>(this IValitRule<TObject, ushort> rule, ushort? value) where TObject : class
            => rule.Satisfies(p => value.HasValue && p == value.Value);


        public static IValitRule<TObject, ushort?> IsEqualTo<TObject>(this IValitRule<TObject, ushort?> rule, ushort value) where TObject : class
            => rule.Satisfies(p => p.HasValue && p.Value == value);

        public static IValitRule<TObject, ushort?> IsEqualTo<TObject>(this IValitRule<TObject, ushort?> rule, ushort? value) where TObject : class
            => rule.Satisfies(p => p.HasValue && value.HasValue && p.Value == value.Value);

        public static IValitRule<TObject, ushort> IsNonZero<TObject>(this IValitRule<TObject, ushort> rule) where TObject : class
            => rule.Satisfies(p => p != 0);

        public static IValitRule<TObject, ushort?> IsNonZero<TObject>(this IValitRule<TObject, ushort?> rule) where TObject : class
            => rule.Satisfies(p => p.HasValue && p.Value != 0);

        public static IValitRule<TObject, ushort?> Required<TObject>(this IValitRule<TObject, ushort?> rule) where TObject : class
            => rule.Satisfies(p => p.HasValue);
    }
}
