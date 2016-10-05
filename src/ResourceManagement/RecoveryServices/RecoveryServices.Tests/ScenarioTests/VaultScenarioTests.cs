﻿//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using Microsoft.Rest.Azure;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System.Linq;
using Xunit;

namespace Microsoft.Azure.Management.RecoveryServices.Tests
{
    public class VaultScenarioTests : TestBase
    {
        [Fact]
        public void CanCreateGetListDeleteVaultTest()
        {
            using (var context = MockContext.Start(this.GetType().FullName))
            {
                using (RecoveryServicesTestBase _testFixture = new RecoveryServicesTestBase(context))
                {
                    string vaultName = VaultDefinition.TestCrud.VaultName;
                    string vaultName2 = VaultDefinition.TestList.VaultName;

                    _testFixture.CreateVault(vaultName);
                    var vault = _testFixture.GetVault(vaultName);
                    Assert.NotNull(vault);

                    _testFixture.CreateVault(vaultName2);
                    var vaults = _testFixture.ListVaults();
                    Assert.NotNull(vaults);
                    Assert.NotEmpty(vaults);
                    Assert.True(vaults.Any(v => v.Name == vaultName));
                    Assert.True(vaults.Any(v => v.Name == vaultName2));

                    _testFixture.DeleteVault(vaultName2);
                    Assert.Throws<CloudException>(() =>
                    {
                        _testFixture.GetVault(vaultName2);
                    });
                }
            }
        }
    }
}
