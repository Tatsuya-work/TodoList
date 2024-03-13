<template>
  <div class="category-tab">
    <div class="title" @click="onClickItem('All Tasks')">All Tasks</div>
    <div v-for="(item, index) in prop.categorys" :key="index" class="item" @click="onClickItem(item)">{{ item }}</div>
  </div>
</template>

<script setup lang="ts">
// Prop定義
const prop = defineProps<{
  categorys: string[];
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
  display: inline-flex;
  align-items: flex-start;
  flex-direction: column;
}

.title {
  cursor: pointer;
  font-weight: 1000;
  font-size: 20px;
  color: var(--font-black);
}

.item {
  cursor: pointer;
  font-weight: 100;
  font-size: 18px;
}
</style>
