(function () {
    'use strict';

    var app = angular.module('app', [
        'ngAnimate',
        'ngSanitize',

        'ui.router',
        'ui.bootstrap',
        'ui.jq',

        'abp'
    ]);

    //Configuration for Angular UI routing.
    app.config([
        '$stateProvider', '$urlRouterProvider', '$locationProvider', '$qProvider',
        function ($stateProvider, $urlRouterProvider, $locationProvider, $qProvider) {
            $locationProvider.hashPrefix('');
            $urlRouterProvider.otherwise('/');
            $qProvider.errorOnUnhandledRejections(false);

            $stateProvider
                .state('home', {
                    url: '/',
                    templateUrl: '/App/Main/views/home/home.cshtml',
                    menu: 'Home' //Matches to name of 'Home' menu in ProjetoClienteNavigationProvider
                })
                .state('about', {
                    url: '/about',
                    templateUrl: '/App/Main/views/about/about.cshtml',
                    menu: 'About' //Matches to name of 'About' menu in ProjetoClienteNavigationProvider
                })
                .state('pedido', {
                    url: '/pedido',
                    templateUrl: '/App/Main/views/pedido/pedido_index.cshtml',
                    menu: 'Pedido' //Matches to name of 'About' menu in ProjetoClienteNavigationProvider
                }).state('cliente', {
                    url: '/cliente',
                    templateUrl: '/App/Main/views/cliente/cliente_index.cshtml',
                    menu: 'Cliente' //Matches to name of 'About' menu in ProjetoClienteNavigationProvider
                });
        }
    ]);
})();