# EntityFrameWork 

## Model 

### 1. Code First
(Entity FrameWork 사용)

1-1. FluentAPI - 설정 클래스에서 체이닝을 통해서 설정을 정의 (POCO 보장)

1-2. Data Annotations - C# Attribute를 사용해서 설정을 정의

### 2. DataBaseFirst
(ADO.NET 사용)

1-1. ModelFirst

1-2. DataBaseFirst

## Migration

- Migration은 DB의 Entity와 Code상의 Model을 동기화 하는 것이다.
- Migration을 한다고 DB에 반영되는 것은 아니다.
- cs파일이 생긴다.
-

### .NET CLI(dotnet-ef) 설치
```shell
$ dotnet tool install --global dotnet-ef
```

### 0. Migration DB에 반영

- .NET CLI

```shell
$ dotnet ef database update
```

#### 1. Add Migration

- .NET CLI

```shell
$ dotnet ef migrations add InitialCreate --context CodeFirstDbContext
```


### 2. Update Migrations To DataBase
```shell
$ dotnet ef database update
```