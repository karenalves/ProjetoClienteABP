(function () {
    'use strict';

    angular
        .module('app')
        .controller('app.views.cliente.cliente_index', ClienteController)

    ClienteController.$inject =
        [
            '$uibModal',
            'abp.services.app.cliente',
            '$state',
            '$timeout'
        ];

    function ClienteController($uibModal, clienteService, $state, $timeout) {
        var vm = this;
        vm.create = create;
        vm.edit = edit;
        vm.delete = Delete;
        vm.refresh = refresh;

        vm.clientes = [];

        activate();

        function activate() {
            abp.ui.setBusy();
            getClientes();
        }

        function refresh() {
            getClientes();
        }

        function getClientes() {
            clienteService.getAllCliente({})
                .then(fillClientes, errorMessage)
                .catch(unblockByError);

            function fillClientes(result) {
                vm.clientes = result.data.clientes;
                abp.ui.clearBusy();
            }

            function unblockByError() {
                abp.ui.clearBusy();
            }
        }

        function errorMessage(result) {
            abp.ui.clearBusy();
            abp.notify.error(result);
        }

        function create() {
            var modalInstance = $uibModal.open({
                templateUrl: '/App/Main/views/cliente/cliente_create_or_edit.cshtml',
                controller: 'app.views.cliente.cliente_create_or_edit as vm',
                backdrop: 'static',
                resolve: {
                    id: function () {
                        return 0;
                    },
                    isEditing: function () {
                        return false;
                    }
                }
            });

            modalInstance.result.then(function () {
                getClientes();
            });
        }

        function edit(cliente) {
            var modalInstance = $uibModal.open({
                templateUrl: '/App/Main/views/cliente/cliente_create_or_edit.cshtml',
                controller: 'app.views.cliente.cliente_create_or_edit as vm',
                backdrop: 'static',
                resolve: {
                    id: function () {
                        return cliente.id;
                    },
                    isEditing: function () {
                        return true;
                    }
                }
            });

            modalInstance.result.then(function () {
                getClientes();
            });
        }

        function Delete(cliente) {
            swal({
                title: "Remover Cliente",
                text: "Você deseja remover o cliente '" + cliente.name + "'?",
                type: "warning",
                showCancelButton: true,
                confirmButtonColor: "#DD6B55",
                confirmButtonText: "Sim!",
                closeOnConfirm: false,
                html: false
            }, function () {
                clienteService.deleteCliente(cliente.id)
                    .then(deletedMessage, errorMessage);
                function deletedMessage() {
                    swal("Deletado!",
                        "Seu Cliente foi deletado.",
                        "success");
                    getClientes();
                }
            });
        }
    }
})();