import type { ProductType } from '../abpecommerce/products/product-type.enum';
import type { EntityDto } from '@abp/ng.core';

export interface CreateUpdateProductDto {
  id?: string;
  categoryId?: string;
  manufacturerId?: string;
  code?: string;
  name?: string;
  slug?: string;
  productType: ProductType;
  sku?: string;
  sortOrder: number;
  visibility: boolean;
  isActive: boolean;
  seoMetaDescription?: string;
  description?: string;
  thumbnailPicture?: string;
}

export interface ProductDto {
  id?: string;
  categoryId?: string;
  manufacturerId?: string;
  code?: string;
  name?: string;
  slug?: string;
  productType: ProductType;
  sku?: string;
  sortOrder: number;
  visibility: boolean;
  isActive: boolean;
  seoMetaDescription?: string;
  description?: string;
  thumbnailPicture?: string;
}

export interface ProductInListDto extends EntityDto<string> {
  categoryId?: string;
  manufacturerId?: string;
  code?: string;
  name?: string;
  slug?: string;
  productType: ProductType;
  sku?: string;
  sortOrder: number;
  visibility: boolean;
  isActive: boolean;
  thumbnailPicture?: string;
}
