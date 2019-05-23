using Abp.Application.Navigation;
using Abp.Localization;

namespace KancelarijaBoilerplate.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class KancelarijaBoilerplateNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.About,
                        L("About"),
                        url: "Home/About",
                        icon: "fa fa-info"
                        )
                    ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Uredjaj,
                        L("Uredjaj"),
                        url: "Uredjaj",
                        icon: "fa fa-info"
                    ).AddItem(
                    new MenuItemDefinition(
                        PageNames.GetAll,
                        L("GetAll"),
                        url: "Uredjaj/GetAll",
                        icon: "fa fa-info"
                    )
                        ).AddItem(
                    new MenuItemDefinition(
                        PageNames.GetById,
                        L("GetById"),
                        url: "Uredjaj/GetById/",
                        icon: "fa fa-info"
                    )
                        ).AddItem(
                    new MenuItemDefinition(
                        PageNames.KreiranjeUredjaja,
                        L("KreiranjeUredjaja"),
                        url: "Uredjaj/KreiranjeUredjaja",
                        icon: "fa fa-info"
                    )
                        )
                    ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Kancelarija,
                        L("Kancelarija"),
                        url: "Kancelarija/",
                        icon: "fa fa-info"
                    )
                    .AddItem(
                    new MenuItemDefinition(
                        PageNames.KreirajKancelariju,
                        L("KreirajKancelariju"),
                        url: "Kancelarija/KreirajKancelariju",
                        icon: "fa fa-info"
                    )
                    ).AddItem(
                    new MenuItemDefinition(
                        PageNames.GetAll,
                        L("GetAll"),
                        url: "Kancelarija/GetAll",
                        icon: "fa fa-info"
                        )
                    ).AddItem(
                            new MenuItemDefinition(
                                PageNames.GetById,
                                L("GetById"),
                                url: "Kancelarija/GetById",
                                icon: "fa fa-info"
                            )
                        )
                    ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Osoba,
                        L("Osoba"),
                        url: "Osoba",
                        icon: "fa fa-info"
                    
                    ).AddItem(
                    new MenuItemDefinition(
                        PageNames.GetAllOsoba,
                        L("GetAllOsoba"),
                        url: "Osoba/GetAllOsoba",
                        icon: "fa fa-info"
                    )
                ).AddItem(
                        new MenuItemDefinition(
                            PageNames.GetOsobaById,
                            L("GetOsobaById"),
                            url: "Osoba/GetOsobaById",
                            icon: "fa fa-info"
                        )
                        ).AddItem(
                        new MenuItemDefinition(
                            PageNames.AddOsoba,
                            L("AddOsoba"),
                            url: "Osoba/AddOsoba",
                            icon: "fa fa-info"
                        )
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.KoriscenjeUredjaja,
                        L("KoriscenjeUredjaja"),
                        url: "KoriscenjeUredjaja",
                        icon: "fa fa-info"
                    )
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.GetAllHistory,
                        L("GetAllHistory"),
                        url: "KoriscenjeUredjaja/GetAllHistory",
                        icon: "fa fa-info"
                    )
                ).AddItem(
                            new MenuItemDefinition(
                                PageNames.CreateHistory,
                                L("CreateHistory"),
                                url: "KoriscenjeUredjaja/CreateHistory",
                                icon: "fa fa-info"
                            )
                        ).AddItem(
                            new MenuItemDefinition(
                                PageNames.GetHistoryById,
                                L("GetHistoryById"),
                                url: "KoriscenjeUredjaja/GetHistoryById",
                                icon: "fa fa-info"
                            )
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.AddLanguage,
                        L("AddLanguage"),
                        url:"Language/AddLanguage",
                        icon: "fa fa-info"
                        )
                    ).AddItem(
                    new MenuItemDefinition(
                        PageNames.AddBlog,
                        L("AddBlog"),
                        url: "Blog/AddBlog",
                        icon: "fa fa-info"
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.GetAll,
                        L("GetAll"),
                        url: "Blog/GetAll",
                        icon: "fa fa-info"
                        )
                    );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, KancelarijaBoilerplateConsts.LocalizationSourceName);
        }
    }
}
