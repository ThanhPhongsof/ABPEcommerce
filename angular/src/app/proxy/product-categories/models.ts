import type { EntityDto } from '@abp/ng.core';

export interface CreateUpdateProductCategoryDto {
  id?: string;
  name?: string;
  code?: string;
  slug?: string;
  sortOrder: number;
  coverPicture?: string;
  visibility: boolean;
  isActive: boolean;
  seoMetaDescription?: string;
}

export interface ProductCategoryDto {
  id?: string;
  name?: string;
  code?: string;
  slug?: string;
  sortOrder: number;
  coverPicture?: string;
  visibility: boolean;
  isActive: boolean;
  seoMetaDescription?: string;
  parentId?: string;
}

export interface ProductCategoryInListDto extends EntityDto<string> {
  name?: string;
  code?: string;
  slug?: string;
  sortOrder: number;
  coverPicture?: string;
  visibility: boolean;
  isActive: boolean;
}
