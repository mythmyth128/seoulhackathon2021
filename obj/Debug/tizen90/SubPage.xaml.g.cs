//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Tizen.NUI.Xaml.XamlResourceIdAttribute("MiniKi.SubPage.xaml", "SubPage.xaml", typeof(global::MiniKi.SubPage))]

namespace MiniKi {
    
    
    [Tizen.NUI.Xaml.XamlFilePathAttribute("SubPage.xaml")]
    [Tizen.NUI.Xaml.XamlCompilationAttribute(global::Tizen.NUI.Xaml.XamlCompilationOptions.Compile)]
    public partial class SubPage : global::Tizen.NUI.Components.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.28.0")]
        public global::Tizen.NUI.GaussianBlurView contentView;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.28.0")]
        public global::Tizen.NUI.BaseComponents.View container;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.28.0")]
        private object eXamlData;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.28.0")]
        private void InitializeComponent() {
            eXamlData = global::Tizen.NUI.EXaml.EXamlExtensions.LoadFromEXamlByRelativePath(this, GetEXamlPath());
            contentView = global::Tizen.NUI.Binding.NameScopeExtensions.FindByName<global::Tizen.NUI.GaussianBlurView>(this, "contentView");
            container = global::Tizen.NUI.Binding.NameScopeExtensions.FindByName<global::Tizen.NUI.BaseComponents.View>(this, "container");
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.28.0")]
        private string GetEXamlPath() {
            return default(string);
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.28.0")]
        private void RemoveEventsInXaml() {
            global::Tizen.NUI.EXaml.EXamlExtensions.RemoveEventsInXaml(eXamlData);
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.28.0")]
        private void ExitXaml() {
            RemoveEventsInXaml();
            global::Tizen.NUI.EXaml.EXamlExtensions.DisposeXamlElements(this);
        }
    }
}
