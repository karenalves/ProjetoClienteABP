﻿using Abp.Application.Navigation;
using Abp.Localization;

namespace ProjetoCliente.Web
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See .cshtml and .js files under App/Main/views/layout/header to know how to render menu.
    /// </summary>
    public class ProjetoClienteNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "Home",
                        new LocalizableString("HomePage", ProjetoClienteConsts.LocalizationSourceName),
                        url: "#/",
                        icon: "fa fa-home"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "About",
                        new LocalizableString("About", ProjetoClienteConsts.LocalizationSourceName),
                        url: "#/about",
                        icon: "fa fa-info"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Pedido",
                        new LocalizableString("Pedido", ProjetoClienteConsts.LocalizationSourceName),
                        url: "#/pedido",
                        icon: "fa fa-info"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Cliente",
                        new LocalizableString("Cliente", ProjetoClienteConsts.LocalizationSourceName),
                        url: "#/cliente",
                        icon: "fa fa-info"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Cliente x Pedido",
                        new LocalizableString("Cliente x Pedido", ProjetoClienteConsts.LocalizationSourceName),
                        url: "#/clientepedido",
                        icon: "fa fa-info"
                        )
                );
        }
    }
}
