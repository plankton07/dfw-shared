using System;
using Newtonsoft.Json;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace GraphQLCodeGen {

    public class CreateAccountGQL {
      /// <summary>
      /// CreateAccountGQL.Request 
      /// <para>Required variables:<br/> { createAccountInput=(AccountInputDto) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = CreateAccountDocument,
          OperationName = "createAccount",
          Variables = variables
        };
      }

      /// <remarks>This method is obsolete. Use Request instead.</remarks>
      public static GraphQLRequest getCreateAccountGQL() {
        return Request();
      }
      
      public static string CreateAccountDocument = @"
        mutation createAccount($createAccountInput: AccountInputDto!) {
          createAccount(createAccountInput: $createAccountInput) {
            resultType
            info {
              accountId
              loginId
              createdTime
              lastLoginTime
            }
          }
        }
        ";
      
    }
    

    public class GetAccountInfoGQL {
      /// <summary>
      /// GetAccountInfoGQL.Request 
      /// <para>Required variables:<br/> { accountId=(double) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = GetAccountInfoDocument,
          OperationName = "getAccountInfo",
          Variables = variables
        };
      }

      /// <remarks>This method is obsolete. Use Request instead.</remarks>
      public static GraphQLRequest getGetAccountInfoGQL() {
        return Request();
      }
      
      public static string GetAccountInfoDocument = @"
        query getAccountInfo($accountId: Float!) {
          getAccountInfo(accountId: $accountId) {
            resultType
            info {
              accountId
              loginId
              createdTime
              lastLoginTime
            }
          }
        }
        ";
      
    }
    

    public class GetAllAccountInfoGQL {
      /// <summary>
      /// GetAllAccountInfoGQL.Request 
      /// </summary>
      public static GraphQLRequest Request() {
        return new GraphQLRequest {
          Query = GetAllAccountInfoDocument,
          OperationName = "getAllAccountInfo"
        };
      }

      /// <remarks>This method is obsolete. Use Request instead.</remarks>
      public static GraphQLRequest getGetAllAccountInfoGQL() {
        return Request();
      }
      
      public static string GetAllAccountInfoDocument = @"
        query getAllAccountInfo {
          getAllAccountInfo {
            resultType
            infos {
              accountId
              loginId
              createdTime
              lastLoginTime
            }
          }
        }
        ";
      
    }
    

    public class GetCachePlayerInfoGQL {
      /// <summary>
      /// GetCachePlayerInfoGQL.Request 
      /// <para>Required variables:<br/> { accountId=(double) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = GetCachePlayerInfoDocument,
          OperationName = "getCachePlayerInfo",
          Variables = variables
        };
      }

      /// <remarks>This method is obsolete. Use Request instead.</remarks>
      public static GraphQLRequest getGetCachePlayerInfoGQL() {
        return Request();
      }
      
      public static string GetCachePlayerInfoDocument = @"
        query getCachePlayerInfo($accountId: Float!) {
          getCachePlayerInfo(accountId: $accountId) {
            resultType
            info {
              accountId
              nick
              createdTime
            }
          }
        }
        ";
      
    }
    

    public class GetEquipDataGQL {
      /// <summary>
      /// GetEquipDataGQL.Request 
      /// <para>Required variables:<br/> { equipIndex=(double), equipCode=(double) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = GetEquipDataDocument,
          OperationName = "getEquipData",
          Variables = variables
        };
      }

      /// <remarks>This method is obsolete. Use Request instead.</remarks>
      public static GraphQLRequest getGetEquipDataGQL() {
        return Request();
      }
      
      public static string GetEquipDataDocument = @"
        query getEquipData($equipIndex: Float!, $equipCode: Float!) {
          getEquipData(equipIndex: $equipIndex, equipCode: $equipCode)
        }
        ";
      
    }
    

    public class GetItemDataGQL {
      /// <summary>
      /// GetItemDataGQL.Request 
      /// <para>Required variables:<br/> { itemIndex=(double) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = GetItemDataDocument,
          OperationName = "getItemData",
          Variables = variables
        };
      }

      /// <remarks>This method is obsolete. Use Request instead.</remarks>
      public static GraphQLRequest getGetItemDataGQL() {
        return Request();
      }
      
      public static string GetItemDataDocument = @"
        query getItemData($itemIndex: Float!) {
          getItemData(itemIndex: $itemIndex)
        }
        ";
      
    }
    

    public class GetPlayerInfoGQL {
      /// <summary>
      /// GetPlayerInfoGQL.Request 
      /// <para>Required variables:<br/> { accountId=(double) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = GetPlayerInfoDocument,
          OperationName = "getPlayerInfo",
          Variables = variables
        };
      }

      /// <remarks>This method is obsolete. Use Request instead.</remarks>
      public static GraphQLRequest getGetPlayerInfoGQL() {
        return Request();
      }
      
      public static string GetPlayerInfoDocument = @"
        query getPlayerInfo($accountId: Float!) {
          getPlayerInfo(accountId: $accountId) {
            resultType
            info {
              accountId
              nick
              createdTime
            }
          }
        }
        ";
      
    }
    

    public class HelloGQL {
      /// <summary>
      /// HelloGQL.Request 
      /// </summary>
      public static GraphQLRequest Request() {
        return new GraphQLRequest {
          Query = HelloDocument,
          OperationName = "hello"
        };
      }

      /// <remarks>This method is obsolete. Use Request instead.</remarks>
      public static GraphQLRequest getHelloGQL() {
        return Request();
      }
      
      public static string HelloDocument = @"
        query hello {
          hello
        }
        ";
      
    }
    

    public class Hello2GQL {
      /// <summary>
      /// Hello2GQL.Request 
      /// </summary>
      public static GraphQLRequest Request() {
        return new GraphQLRequest {
          Query = Hello2Document,
          OperationName = "hello2"
        };
      }

      /// <remarks>This method is obsolete. Use Request instead.</remarks>
      public static GraphQLRequest getHello2GQL() {
        return Request();
      }
      
      public static string Hello2Document = @"
        query hello2 {
          hello2
        }
        ";
      
    }
    

    public class LoginGQL {
      /// <summary>
      /// LoginGQL.Request 
      /// <para>Required variables:<br/> { accountId=(double) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public static GraphQLRequest Request(object variables = null) {
        return new GraphQLRequest {
          Query = LoginDocument,
          OperationName = "login",
          Variables = variables
        };
      }

      /// <remarks>This method is obsolete. Use Request instead.</remarks>
      public static GraphQLRequest getLoginGQL() {
        return Request();
      }
      
      public static string LoginDocument = @"
        query login($accountId: Float!) {
          login(accountId: $accountId) {
            resultType
            info {
              accountId
              loginId
              createdTime
              lastLoginTime
            }
          }
        }
        ";
      
    }
    
}