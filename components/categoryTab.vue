<template>
  <div class="category-tab">
    <div class="title" @click="onClickItem('All Tasks')"> All Tasks </div>
    <div class="item" v-for="(item, index) in category.items" :key="index" @click="onClickItem(item)"> {{ item }} </div>
  </div>
</template>

<script setup lang="ts">
// Prop定義
const category = defineProps<{
  items: string[]
}>();

// Emit定義
const emit = defineEmits<{
  (e: "onClick", item: string): void;
}>();
const onClickItem = (item: string): void => {
  emit("onClick", item);
};
</script>

<style>
.category-tab {
  margin: 0%;
  padding: 0%;
  display: inline-flex;
  align-items: flex-start;
  flex-direction: column;
}

.title {
  cursor: pointer;
  font-weight: 1000;
  font-size: 20px;
}

.item {
  cursor: pointer;
  font-weight: 100;
  font-size: 18px;
}
</style>