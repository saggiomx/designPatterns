namespace BuildPattern.FunctionalBuilder
{
    public static class PersonBuilderExt
    {
        public static PersonBuilder WorkAs(this PersonBuilder builder, string position)
        {
            builder.Actions.Add(p => { p.Position = position;});
            return builder;
        }
    }
}
