﻿using System.Collections.Generic;
using System.Linq;

namespace CanvasAppPackager.Poco
{
    public class OverridableProperties
    {
    }

    public class Property
    {
        public string Name { get; set; }
        public ControlThisItemType InvariantType { get; set; }
        public string PropertyRuleCategory { get; set; }
        public string PropertyDisplayName { get; set; }
    }

    public class Template
    {
        public string Id { get; set; }
        public string Version { get; set; }
        public string Name { get; set; }
        public bool? FirstParty { get; set; }
        public bool IsCustomGroupControlTemplate { get; set; }
        public string CustomGroupControlTemplateName { get; set; }
        public string CustomControlDefinitionJson { get; set; }
        public string DynamicControlDefinitionJson { get; set; }
        public OverridableProperties OverridableProperties { get; set; }
    }

    public class TypeTemplate
    {
        public string TemplateName { get; set; }
        public bool IsMetaLoc { get; set; }
        public bool Intangible { get; set; }
        public bool IsDataLimited { get; set; }
        public ControlThisItemType ExpandoType { get; set; }
        public List<Property> Properties { get; set; }
    }

    public class Rule
    {
        public string Property { get; set; }
        public string Category { get; set; }
        public string InvariantScript { get; set; }
        public string NameMap { get; set; }
    }

    public class ControlPropertyState
    {
        public string InvariantPropertyName { get; set; }
        public bool AutoRuleBindingEnabled { get; set; }
        public string AutoRuleBindingString { get; set; }
        public string NameMapSourceSchema { get; set; }
        public bool IsLockable { get; set; }
        public string AFDDataSourceName { get; set; }
    }

    public class ControlType
    {
        public string Name { get; set; }
        public string Kind { get; set; }
        public string EnumString { get; set; }
        public TypeTemplate Template { get; set; }
        public List<ControlType> Type { get; set; }
        public List<string> ProjectionInfoDataSources { get; set; }
    }

    public class ControlThisItemType
    {
        public string Version { get; set; }
        public ControlType Type { get; set; }
    }

    public class Child : IControl
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public Template Template { get; set; }
        public double Index { get; set; }
        public int? PublishOrderIndex { get; set; }
        public string VariantName { get; set; }
        public string LayoutName { get; set; }
        public string MetaDataIDKey { get; set; }
        public bool PersistMetaDataIDKey { get; set; }
        public bool IsFromScreenLayout { get; set; }
        public string StyleName { get; set; }
        public string Parent { get; set; }
        public bool IsDataControl { get; set; }
        public bool IsGroupControl { get; set; }
        public bool IsAutoGenerated { get; set; }
        public object PropToDynamicType { get; set; }
        public List<Rule> Rules { get; set; }
        public List<ControlPropertyState> ControlPropertyState { get; set; }
        public bool IsLocked { get; set; }
        public string ControlUniqueId { get; set; }
        public ControlThisItemType ControlThisItemType { get; set; }
        public List<Child> Children { get; set; }
        public List<ChildOrder> ChildrenOrder { get; set; }

        public List<string> GroupedControlsKey { get; set; }

        public Child()
        {
            Children = new List<Child>();
        }
    }

    public class ChildOrder
    {
        public List<ChildOrder> ChildrenOrder { get; set; }
        public string Name { get; set; }
    }

    public class TopParent : IControl
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public Template Template { get; set; }
        public double Index { get; set; }
        public int? PublishOrderIndex { get; set; }
        public string VariantName { get; set; }
        public string LayoutName { get; set; }
        public string MetaDataIDKey { get; set; }
        public bool PersistMetaDataIDKey { get; set; }
        public bool IsFromScreenLayout { get; set; }
        public string StyleName { get; set; }
        public string Parent { get; set; }
        public bool IsDataControl { get; set; }
        public bool IsGroupControl { get; set; }
        public bool IsAutoGenerated { get; set; }
        public object PropToDynamicType { get; set; }
        public List<Rule> Rules { get; set; }
        public List<ControlPropertyState> ControlPropertyState { get; set; }
        public bool IsLocked { get; set; }
        public string ControlUniqueId { get; set; }
        public List<Child> Children { get; set; }
        public List<ChildOrder> ChildrenOrder { get; set; }

        public TopParent()
        {
            Children = new List<Child>();
        }
    }

    public class CanvasAppScreen
    {
        public TopParent TopParent { get; set; }
    }

    public interface IControl
    {
        string Name { get; set; }
        List<Rule> Rules { get; set; }
        string ControlUniqueId { get; set; }
        List<Child> Children { get; set; }
        List<ChildOrder> ChildrenOrder { get; set; }
        int? PublishOrderIndex { get; set; }
    }
}
