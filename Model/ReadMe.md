# DB ����

## EntityFrameWork ���

### Model ����

#### 1. Code First ���

1-1. FluentAPI - �ϳ��� �������Ͽ��� Entity �� DB������ �����ϴ�. - ü�̴��� ���� �����ذ�

1-2. Data Annotations - �پ �������� ���´�. - �������̼��� ���� �˾Ƽ� �������ش�.

#### 2. EF Designer ���

1-1. ModelFirst

1-2. DataBaseFirst

### Migration

- Migration은 DB의 Entity와 Code상의 Model을 동기화 하는 것이다.
- Migration을 한다고 DB에 반영되는 것은 아니다.
- cs파일이 생긴다.
-

### 0. Migration DB에 반영

- .NET CLI

```
dotnet ef database update
```

#### 1. Add Migration

- .NET CLI

```shell
dotnet ef migrations add InitialCreate --context CodeFirstDbContext
```
