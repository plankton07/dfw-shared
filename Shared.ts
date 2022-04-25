export type Maybe<T> = T | null;
export type InputMaybe<T> = Maybe<T>;
export type Exact<T extends { [key: string]: unknown }> = { [K in keyof T]: T[K] };
export type MakeOptional<T, K extends keyof T> = Omit<T, K> & { [SubKey in K]?: Maybe<T[SubKey]> };
export type MakeMaybe<T, K extends keyof T> = Omit<T, K> & { [SubKey in K]: Maybe<T[SubKey]> };
/** All built-in and custom scalars, mapped to their actual values */
export type Scalars = {
  ID: string;
  String: string;
  Boolean: boolean;
  Int: number;
  Float: number;
};

export type AccountInfoDto = {
  __typename?: 'AccountInfoDto';
  accountId: Scalars['String'];
  createdTime: Scalars['String'];
  lastLoginTime: Scalars['String'];
  loginId: Scalars['String'];
};

export type AccountInfoOutput = {
  __typename?: 'AccountInfoOutput';
  info: AccountInfoDto;
  resultType: ResultType;
};

export type AccountInputDto = {
  loginId: Scalars['String'];
};

export type AllAccountInfosOutput = {
  __typename?: 'AllAccountInfosOutput';
  infos: AccountInfoDto;
  resultType: ResultType;
};

export type AuthOutput = {
  __typename?: 'AuthOutput';
  info: AccountInfoDto;
  resultType: ResultType;
  token?: Maybe<Scalars['String']>;
};

export type Mutation = {
  __typename?: 'Mutation';
  createAccount: AccountInfoOutput;
};


export type MutationCreateAccountArgs = {
  createAccountInput: AccountInputDto;
};

export type PlayerInfoDto = {
  __typename?: 'PlayerInfoDto';
  accountId: Scalars['Float'];
  createdTime: Scalars['String'];
  nick: Scalars['String'];
};

export type PlayerInfoOutput = {
  __typename?: 'PlayerInfoOutput';
  info?: Maybe<PlayerInfoDto>;
  resultType: ResultType;
};

export type Query = {
  __typename?: 'Query';
  auth: AuthOutput;
  getAccountInfo: AccountInfoOutput;
  getAllAccountInfo: AllAccountInfosOutput;
  getCachePlayerInfo: PlayerInfoOutput;
  getEquipData: Scalars['String'];
  getItemData: Scalars['String'];
  getPlayerInfo: PlayerInfoOutput;
  hello: Scalars['String'];
  hello2: Scalars['String'];
  login: AccountInfoOutput;
};


export type QueryAuthArgs = {
  id: Scalars['String'];
};


export type QueryGetAccountInfoArgs = {
  accountId: Scalars['Float'];
};


export type QueryGetCachePlayerInfoArgs = {
  accountId: Scalars['Float'];
};


export type QueryGetEquipDataArgs = {
  equipCode: Scalars['Float'];
  equipIndex: Scalars['Float'];
};


export type QueryGetItemDataArgs = {
  itemIndex: Scalars['Float'];
};


export type QueryGetPlayerInfoArgs = {
  accountId: Scalars['Float'];
};


export type QueryLoginArgs = {
  accountId: Scalars['Float'];
};

export enum ResultType {
  Fail = 'FAIL',
  None = 'NONE',
  Success = 'SUCCESS'
}

export type CreateAccountMutationVariables = Exact<{
  createAccountInput: AccountInputDto;
}>;


export type CreateAccountMutation = { __typename?: 'Mutation', createAccount: { __typename?: 'AccountInfoOutput', resultType: ResultType, info: { __typename?: 'AccountInfoDto', accountId: string, loginId: string, createdTime: string, lastLoginTime: string } } };

export type GetAccountInfoQueryVariables = Exact<{
  accountId: Scalars['Float'];
}>;


export type GetAccountInfoQuery = { __typename?: 'Query', getAccountInfo: { __typename?: 'AccountInfoOutput', resultType: ResultType, info: { __typename?: 'AccountInfoDto', accountId: string, loginId: string, createdTime: string, lastLoginTime: string } } };

export type GetAllAccountInfoQueryVariables = Exact<{ [key: string]: never; }>;


export type GetAllAccountInfoQuery = { __typename?: 'Query', getAllAccountInfo: { __typename?: 'AllAccountInfosOutput', resultType: ResultType, infos: { __typename?: 'AccountInfoDto', accountId: string, loginId: string, createdTime: string, lastLoginTime: string } } };

export type GetCachePlayerInfoQueryVariables = Exact<{
  accountId: Scalars['Float'];
}>;


export type GetCachePlayerInfoQuery = { __typename?: 'Query', getCachePlayerInfo: { __typename?: 'PlayerInfoOutput', resultType: ResultType, info?: { __typename?: 'PlayerInfoDto', accountId: number, nick: string, createdTime: string } | null } };

export type GetEquipDataQueryVariables = Exact<{
  equipIndex: Scalars['Float'];
  equipCode: Scalars['Float'];
}>;


export type GetEquipDataQuery = { __typename?: 'Query', getEquipData: string };

export type GetItemDataQueryVariables = Exact<{
  itemIndex: Scalars['Float'];
}>;


export type GetItemDataQuery = { __typename?: 'Query', getItemData: string };

export type GetPlayerInfoQueryVariables = Exact<{
  accountId: Scalars['Float'];
}>;


export type GetPlayerInfoQuery = { __typename?: 'Query', getPlayerInfo: { __typename?: 'PlayerInfoOutput', resultType: ResultType, info?: { __typename?: 'PlayerInfoDto', accountId: number, nick: string, createdTime: string } | null } };

export type HelloQueryVariables = Exact<{ [key: string]: never; }>;


export type HelloQuery = { __typename?: 'Query', hello: string };

export type Hello2QueryVariables = Exact<{ [key: string]: never; }>;


export type Hello2Query = { __typename?: 'Query', hello2: string };

export type LoginQueryVariables = Exact<{
  accountId: Scalars['Float'];
}>;


export type LoginQuery = { __typename?: 'Query', login: { __typename?: 'AccountInfoOutput', resultType: ResultType, info: { __typename?: 'AccountInfoDto', accountId: string, loginId: string, createdTime: string, lastLoginTime: string } } };
