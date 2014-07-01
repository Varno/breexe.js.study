namespace Todo.Models
{
    using Breeze.ContextProvider.EF6;
    using System;
    using System.Data.Entity;
    using Todo.Models.Entities;

    public class DataService : EFContextProvider<TodosContext>
    {
        protected override System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.List<Breeze.ContextProvider.EntityInfo>> BeforeSaveEntities(System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.List<Breeze.ContextProvider.EntityInfo>> saveMap)
        {
            return base.BeforeSaveEntities(saveMap);
        }

    }
}