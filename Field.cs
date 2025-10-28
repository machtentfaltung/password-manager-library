// Copyright © 2025 Matei Pralea <matei.pralea@proton.me>
// SPDX-License-Identifier: MIT OR Apache-2.0

namespace PasswordManager;

public enum FieldType 
{
    Hidden,
    Plain,
}

public class Field(string title, FieldType type, string content)
{
    public string Title { get; set; } = title;
    public FieldType Type { get; set; } = type;
    public string Content { get; set; } = content;
}