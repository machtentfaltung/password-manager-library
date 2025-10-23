// Password Manager Library
// Copyright (C) 2024-2025 Matei Pralea <matei.pralea@proton.me>
//
// This library is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with this library.  If not, see <https://www.gnu.org/licenses/>.

using System;

namespace PasswordManager;

public class Manager
{
    public List<Account> Accounts { get; private set; }

    public Manager()
    {
        Accounts = new List<Account>();
    }

    public void AddAccount(Account account)
    {
        if (Accounts.Contains(account))
            throw new Exception("Account already exists");
        Accounts.Add(account);
    }

    public void RemoveAccount(Account account)
    {
        if (!Accounts.Contains(account))
            throw new Exception("Account not found");
        Accounts.Remove(account);
    }
}