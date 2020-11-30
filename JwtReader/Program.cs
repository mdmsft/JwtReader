﻿using System.IdentityModel.Tokens.Jwt;
using static System.Console;

WriteLine("Token (leave empty to use a sample):");

string jwt = ReadLine();

if (string.IsNullOrEmpty(jwt))
{
    jwt = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJpc3MiOiJodHRwczovL21kbXNiYy5iMmNsb2dpbi5jb20vYWIzNDUxMDUtM2FjMS00N2U2LWEyNWUtYzMxNzE1MGIxYzA1L3YyLjAvIiwiZXhwIjoxNjA1MDM0NjAxLCJuYmYiOjE2MDUwMzEwMDEsImF1ZCI6ImJiYzE0N2YxLTI0MjQtNDAyYS04NGUyLTZiY2VjN2YxNzZkNiIsInN1YiI6IjM3ZmQ4Njk4LWRiYmYtNDIxYy1iMTg0LWM3ZDcxMmE4NzRhZCIsIm5hbWUiOiJNYXggTXVzdGVybWFubiIsImV4dGVuc2lvbl9DdXN0b21lciI6IlRlc3QgMiIsInRmcCI6IkIyQ18xX1NJIiwic2NwIjoidXNlcl9pbXBlcnNvbmF0aW9uIiwiYXpwIjoiYmJjMTQ3ZjEtMjQyNC00MDJhLTg0ZTItNmJjZWM3ZjE3NmQ2IiwidmVyIjoiMS4wIiwiaWF0IjoxNjA1MDMxMDAxfQ.RW5LSAEHaa-HaF26crmz1aOjgHeYUiyCD62-8-sfxS35XpN4QJVZErTXl8SBJzonf64yyF8dL0ZMYxneK-gQZHqrhOidMPvZX0YE9JlSZAuncBW63mkjeJsbvgcjXJa_HgCCbdgqfEdvhOfG4K2GoNjkBQ4INjfoFtFVrkk0I65ecOFi0ptNtiJKcZx5jgKREyIY6rBXWdCXZSGvyqLodJ9T2MriIGkUWsdB5H_LH6VYbPR3AouzWyHDYPWbvdAxMmOUIzIKhOyDPYqh-L8tAVWXDFrI3cpCOp4Weg92BxtOv7rdqSrzXx3uTKv6aJGIjK7Ya4XvARh1IQptpc32Vw";
}

var handler = new JwtSecurityTokenHandler();
JwtSecurityToken token = handler.ReadJwtToken(jwt);

WriteLine();

PrintClaims(token);

ReadLine();

static void PrintClaims(JwtSecurityToken token)
{
    WriteLine($"{nameof(token.Claims)}:");
    foreach (var claim in token.Claims)
    {
        WriteLine($"* {claim.Type}: {claim.Value}");
    }
}