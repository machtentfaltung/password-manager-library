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

namespace PasswordManager;

public class Account
{
    public string Name { get; private set; }
    public string PasswordHash { get; private set; }
    public string PasswordSalt { get; private set; }
    public bool IsLocked { get; private set; }
    public List<Entry> Entries { get; private set; }

    public Account(string name, string password)
    {
        Name = name;
        PasswordSalt = Hasher.GenerateSalt();
        PasswordHash = Hasher.Hash(password + "$" + PasswordSalt);
        IsLocked = true;
        Entries = new List<Entry>();
    }

    public void ChangeName(string name)
    {
        Name = name;
    }

    public void ChangePassword(string newPassword)
    {
        PasswordHash = Hasher.Hash(newPassword + "$" + PasswordSalt);
    }

    public void Lock()
    {
        IsLocked = true;
    }

    public void Unlock()
    {
        IsLocked = false;
    }

    public void AddEntry(Entry entry)
    {
        if (Entries.Contains(entry))
            throw new Exception("Entry already exists");
        Entries.Add(entry);
    }

    public void RemoveEntry(Entry entry)
    {
        if (!Entries.Contains(entry))
            throw new Exception("Entry not found");
        Entries.Remove(entry);
    }
}