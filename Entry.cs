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

public class Entry(string title, string username, string email, string password)
{
    public string Title { get; private set; } = title;
    public string Username { get; private set; } = username;
    public string Email { get; private set; } = email;
    public string Password { get; private set; } = password;
    public List<Field> Fields { get; private set; } = new();

    public void AddField(Field field)
    {
        if (Fields.Contains(field))
            throw new Exception("Field already exists");
        Fields.Add(field);
    }

    public void RemoveField(Field field)
    {
        if (!Fields.Contains(field))
            throw new Exception("Field not found");
        Fields.Add(field);
    }
}